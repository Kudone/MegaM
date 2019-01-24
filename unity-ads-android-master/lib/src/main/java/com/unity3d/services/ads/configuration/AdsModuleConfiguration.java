package com.unity3d.services.ads.configuration;

import android.os.ConditionVariable;

import com.unity3d.ads.IUnityAdsListener;
import com.unity3d.ads.UnityAds;
import com.unity3d.services.ads.placement.Placement;
import com.unity3d.services.ads.properties.AdsProperties;
import com.unity3d.services.core.configuration.Configuration;
import com.unity3d.services.core.log.DeviceLog;
import com.unity3d.services.core.misc.Utilities;

import java.net.InetAddress;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.HashMap;
import java.util.Map;

public class AdsModuleConfiguration implements IAdsModuleConfiguration {
	private InetAddress _address;

	public Class[] getWebAppApiClassList() {
		Class[] list = {
			com.unity3d.services.ads.api.AdUnit.class,
			com.unity3d.services.ads.api.Listener.class,
			com.unity3d.services.ads.api.VideoPlayer.class,
			com.unity3d.services.ads.api.Placement.class,
			com.unity3d.services.ads.api.WebPlayer.class,
			com.unity3d.services.ads.api.Purchasing.class,
			com.unity3d.services.ads.api.AdsProperties.class
		};

		return list;
	}

	public boolean resetState(Configuration configuration) {
		Placement.reset();
		return true;
	}

	public boolean initModuleState(Configuration configuration) {
		DeviceLog.debug("Unity Ads init: checking for ad blockers");

		final String configHost;
		try {
			configHost = new URL(configuration.getConfigUrl()).getHost();
		} catch(MalformedURLException e) {
			return true;
		}

		final ConditionVariable cv = new ConditionVariable();

		new Thread() {
			@Override
			public void run() {
				try {
					_address = InetAddress.getByName(configHost);
					cv.open();
				} catch(Exception e) {
					DeviceLog.exception("Couldn't get address. Host: " + configHost, e);
					cv.open();
				}
			}
		}.start();

		// This is checking if config url is in /etc/hosts or equivalent. No need for long wait.
		boolean success = cv.block(2000);
		if(success && _address != null && _address.isLoopbackAddress()) {
			DeviceLog.error("Unity Ads init: halting init because Unity Ads config resolves to loopback address (due to ad blocker?)");

			final IUnityAdsListener listener = AdsProperties.getListener();
			if(listener != null) {
				Utilities.runOnUiThread(new Runnable() {
					@Override
					public void run() {
						listener.onUnityAdsError(UnityAds.UnityAdsError.AD_BLOCKER_DETECTED, "Unity Ads config server resolves to loopback address (due to ad blocker?)");
					}
				});
			}
			return false;
		}

		return true;
	}

	public boolean initErrorState(Configuration configuration, String state, String errorMessage) {
		final IUnityAdsListener listener = UnityAds.getListener();
		final String message = "Init failed in " + state;
		if(AdsProperties.getListener() != null) {
			Utilities.runOnUiThread(new Runnable() {
				@Override
				public void run() {
					listener.onUnityAdsError(UnityAds.UnityAdsError.INITIALIZE_FAILED, message);
				}
			});
		}
		return true;
	}

	public boolean initCompleteState(Configuration configuration) {
		return true;
	}

	public Map<String, Class> getAdUnitViewHandlers() {
		Map<String, Class> handlers = new HashMap<>();
		handlers.put("videoplayer", com.unity3d.services.ads.adunit.VideoPlayerHandler.class);
		handlers.put("webplayer", com.unity3d.services.ads.adunit.WebPlayerHandler.class);
		handlers.put("webview", com.unity3d.services.ads.adunit.WebViewHandler.class);

		return handlers;
	}
}
