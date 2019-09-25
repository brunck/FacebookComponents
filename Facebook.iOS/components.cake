var FACEBOOK_SDK_VERSION = "5.6.0";

// Artifacts available to be built.
Artifact ACCOUNT_KIT_ARTIFACT = new Artifact ("AccountKit", "5.4.0", "8.0");
Artifact AUDIENCE_NETWORK_ARTIFACT = new Artifact ("FBAudienceNetwork", "5.3.2", "9.0",  nugetVersion: $"5.3.2.1", csprojName: "AudienceNetwork");
Artifact CORE_KIT_ARTIFACT = new Artifact ("FBSDKCoreKit", FACEBOOK_SDK_VERSION, "8.0", csprojName: "CoreKit");
Artifact FACEBOOK_SDKS_ARTIFACT = new Artifact ("FacebookSdks", FACEBOOK_SDK_VERSION, "8.0", buildOrder: 3);
Artifact LOGIN_KIT_ARTIFACT = new Artifact ("FBSDKLoginKit", FACEBOOK_SDK_VERSION, "8.0", csprojName: "LoginKit", buildOrder: 2);
Artifact MARKETING_KIT_ARTIFACT = new Artifact ("FBSDKMarketingKit", "5.5.0", "8.0", csprojName: "MarketingKit", buildOrder: 2, includeDependencies: false);
Artifact PLACES_KIT_ARTIFACT = new Artifact ("FBSDKPlacesKit", FACEBOOK_SDK_VERSION, "8.0", csprojName: "PlacesKit", buildOrder: 2);
Artifact SHARE_KIT_ARTIFACT = new Artifact ("FBSDKShareKit", FACEBOOK_SDK_VERSION, "8.0", csprojName: "ShareKit", buildOrder: 2);

var ARTIFACTS = new Dictionary<string, Artifact> {
	{ "AccountKit", ACCOUNT_KIT_ARTIFACT },
	{ "AudienceNetwork", AUDIENCE_NETWORK_ARTIFACT },
	{ "CoreKit", CORE_KIT_ARTIFACT },
	{ "FacebookSdks", FACEBOOK_SDKS_ARTIFACT },
	{ "LoginKit", LOGIN_KIT_ARTIFACT },
	{ "MarketingKit", MARKETING_KIT_ARTIFACT },
	{ "PlacesKit", PLACES_KIT_ARTIFACT },
	{ "ShareKit", SHARE_KIT_ARTIFACT },
};

void SetArtifactsDependencies ()
{
	FACEBOOK_SDKS_ARTIFACT.Dependencies = new [] { LOGIN_KIT_ARTIFACT, MARKETING_KIT_ARTIFACT, PLACES_KIT_ARTIFACT, SHARE_KIT_ARTIFACT };
	LOGIN_KIT_ARTIFACT.Dependencies = new [] { CORE_KIT_ARTIFACT };
	MARKETING_KIT_ARTIFACT.Dependencies = new [] { CORE_KIT_ARTIFACT };
	PLACES_KIT_ARTIFACT.Dependencies = new [] { CORE_KIT_ARTIFACT };
	SHARE_KIT_ARTIFACT.Dependencies = new [] { CORE_KIT_ARTIFACT };
}
