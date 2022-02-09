// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	public sealed partial class SessionModification : Handle
	{
		public SessionModification()
		{
		}

		public SessionModification(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="AddAttribute" /> API.
		/// </summary>
		public const int SessionmodificationAddattributeApiLatest = 1;

		/// <summary>
		/// Maximum length of the name of the attribute associated with the session
		/// </summary>
		public const int SessionmodificationMaxSessionAttributeLength = 64;

		/// <summary>
		/// Maximum number of attributes allowed on the session
		/// </summary>
		public const int SessionmodificationMaxSessionAttributes = 64;

		/// <summary>
		/// Maximum number of characters allowed in the session id override
		/// </summary>
		public const int SessionmodificationMaxSessionidoverrideLength = 64;

		/// <summary>
		/// Minimum number of characters allowed in the session id override
		/// </summary>
		public const int SessionmodificationMinSessionidoverrideLength = 16;

		/// <summary>
		/// The most recent version of the <see cref="RemoveAttribute" /> API.
		/// </summary>
		public const int SessionmodificationRemoveattributeApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetBucketId" /> API.
		/// </summary>
		public const int SessionmodificationSetbucketidApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetHostAddress" /> API.
		/// </summary>
		public const int SessionmodificationSethostaddressApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetInvitesAllowed" /> API.
		/// </summary>
		public const int SessionmodificationSetinvitesallowedApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetJoinInProgressAllowed" /> API.
		/// </summary>
		public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetMaxPlayers" /> API.
		/// </summary>
		public const int SessionmodificationSetmaxplayersApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetPermissionLevel" /> API.
		/// </summary>
		public const int SessionmodificationSetpermissionlevelApiLatest = 1;

		/// <summary>
		/// Associate an attribute with this session
		/// An attribute is something that may or may not be advertised with the session.
		/// If advertised, it can be queried for in a search, otherwise the data remains local to the client
		/// </summary>
		/// <param name="options">Options to set the attribute and its advertised state</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.InvalidParameters" /> if the attribution is missing information or otherwise invalid
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result AddAttribute(SessionModificationAddAttributeOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationAddAttributeOptionsInternal, SessionModificationAddAttributeOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_AddAttribute(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Release the memory associated with session modification.
		/// This must be called on data retrieved from <see cref="SessionsInterface.CreateSessionModification" /> or <see cref="SessionsInterface.UpdateSessionModification" />
		/// <seealso cref="SessionsInterface.CreateSessionModification" />
		/// <seealso cref="SessionsInterface.UpdateSessionModification" />
		/// </summary>
		/// <param name="sessionModificationHandle">- The session modification handle to release</param>
		public void Release()
		{
			Bindings.EOS_SessionModification_Release(InnerHandle);
		}

		/// <summary>
		/// Remove an attribute from this session
		/// </summary>
		/// <param name="options">Specify the key of the attribute to remove</param>
		/// <returns>
		/// <see cref="Result.Success" /> if removing this parameter was successful
		/// <see cref="Result.InvalidParameters" /> if the key is null or empty
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result RemoveAttribute(SessionModificationRemoveAttributeOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationRemoveAttributeOptionsInternal, SessionModificationRemoveAttributeOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_RemoveAttribute(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Set the bucket ID associated with this session.
		/// Values such as region, game mode, etc can be combined here depending on game need.
		/// Setting this is strongly recommended to improve search performance.
		/// </summary>
		/// <param name="options">Options associated with the bucket ID of the session</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.InvalidParameters" /> if the bucket ID is invalid or null
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetBucketId(SessionModificationSetBucketIdOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationSetBucketIdOptionsInternal, SessionModificationSetBucketIdOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_SetBucketId(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Set the host address associated with this session
		/// Setting this is optional, if the value is not set the SDK will fill the value in from the service.
		/// It is useful to set if other addressing mechanisms are desired or if LAN addresses are preferred during development
		/// 
		/// @note No validation of this value occurs to allow for flexibility in addressing methods
		/// </summary>
		/// <param name="options">Options associated with the host address of the session</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.InvalidParameters" /> if the host ID is an empty string
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetHostAddress(SessionModificationSetHostAddressOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationSetHostAddressOptionsInternal, SessionModificationSetHostAddressOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_SetHostAddress(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Allows enabling or disabling invites for this session.
		/// The session will also need to have `bPresenceEnabled` true.
		/// </summary>
		/// <param name="options">Options associated with invites allowed flag for this session.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetInvitesAllowed(SessionModificationSetInvitesAllowedOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationSetInvitesAllowedOptionsInternal, SessionModificationSetInvitesAllowedOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_SetInvitesAllowed(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Set whether or not join in progress is allowed
		/// Once a session is started, it will no longer be visible to search queries unless this flag is set or the session returns to the pending or ended state
		/// </summary>
		/// <param name="options">Options associated with setting the join in progress state the session</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetJoinInProgressAllowed(SessionModificationSetJoinInProgressAllowedOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationSetJoinInProgressAllowedOptionsInternal, SessionModificationSetJoinInProgressAllowedOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_SetJoinInProgressAllowed(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Set the maximum number of players allowed in this session.
		/// When updating the session, it is not possible to reduce this number below the current number of existing players
		/// </summary>
		/// <param name="options">Options associated with max number of players in this session</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetMaxPlayers(SessionModificationSetMaxPlayersOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationSetMaxPlayersOptionsInternal, SessionModificationSetMaxPlayersOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_SetMaxPlayers(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Set the session permissions associated with this session.
		/// The permissions range from "public" to "invite only" and are described by <see cref="OnlineSessionPermissionLevel" />
		/// </summary>
		/// <param name="options">Options associated with the permission level of the session</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this parameter was successful
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetPermissionLevel(SessionModificationSetPermissionLevelOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SessionModificationSetPermissionLevelOptionsInternal, SessionModificationSetPermissionLevelOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_SessionModification_SetPermissionLevel(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}
	}
}