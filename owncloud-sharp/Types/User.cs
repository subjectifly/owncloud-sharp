﻿using System;

namespace owncloudsharp.Types
{
	/// <summary>
	/// ownCloud user information.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Gets or sets the users E-mail.
		/// </summary>
		/// <value>The E mail.</value>
		public string EMail { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="owncloudsharp.Types.User"/> is enabled.
		/// </summary>
		/// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets the users display name.
		/// </summary>
		/// <value>The display name.</value>
		public string DisplayName { get; set; }
        /// <summary>
        /// Path to users home directory on the server
        /// </summary>
        /// <value>path to home directory</value>
        public string Home { get; set; }
        /// <summary>
        /// Indicates if two factor authentication has been enabled
        /// </summary>
        /// <value><c>true</c> if two factor auth enabled; otherwise, <c>false</c>.</value>
        public bool TwoFactorAuthEnabled { get; set; }
        /// <summary>
		/// Gets or sets the users storage quota.
		/// </summary>
		/// <value>The quota.</value>
		public Quota Quota { get; set; }

        /// <summary>
        /// Converts a dynamic JSON object to a User instance
        /// </summary>
        /// <returns>User object instance</returns>
        /// <param name="json">JSON to convert</param>
        public static User JSonDeserialize(dynamic json)
        {
            return new User()
            {
                EMail = json.email,
                Enabled = json.enabled,
                DisplayName = json.displayname,
                Home = json.home,
                TwoFactorAuthEnabled = json.two_factor_auth_enabled,
                Quota = Quota.JSonDeserialize(json.quota)
            };
        }
	}

	/// <summary>
	/// User specific storage quota.
	/// </summary>
	public class Quota {
		/// <summary>
		/// Gets or sets the free storage space in bytes.
		/// </summary>
		/// <value>The free.</value>
		public double Free { get; set; }
		/// <summary>
		/// Gets or sets the used storage space in bytes.
		/// </summary>
		/// <value>The used.</value>
		public double Used { get; set; }
		/// <summary>
		/// Gets or sets the total storage space in bytes.
		/// </summary>
		/// <value>The total.</value>
		public double Total { get; set; }
		/// <summary>
		/// Gets or sets the relative storage space in bytes.
		/// </summary>
		/// <value>The relative.</value>
		public double Relative { get; set; }

        /// <summary>
        /// Converts a dynamic JSON object to a Quota instance
        /// </summary>
        /// <returns>Quota object instance.</returns>
        /// <param name="json">JSON to convert.</param>
        public static Quota JSonDeserialize(dynamic json)
        {
            return new Quota()
            {
                Free = json.free,
                Used = json.used,
                Total = json.total,
                Relative = json.relative
            };
        }
	}
}

