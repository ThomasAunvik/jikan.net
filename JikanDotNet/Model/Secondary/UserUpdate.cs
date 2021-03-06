﻿using Newtonsoft.Json;
using System;

namespace JikanDotNet
{
	/// <summary>
	/// Single base user update model class.
	/// </summary>
	public class UserUpdate
	{
		/// <summary>
		/// Username.
		/// </summary>
		[JsonProperty(PropertyName = "username")]
		public string Username { get; set; }

		/// <summary>
		/// User's image URL
		/// </summary>
		[JsonProperty(PropertyName = "image_url")]
		public string ImageURL { get; set; }

		/// <summary>
		/// User's URL
		/// </summary>
		[JsonProperty(PropertyName = "url")]
		public string URL { get; set; }

		/// <summary>
		/// User's score.
		/// </summary>
		[JsonProperty(PropertyName = "score")]
		public int? Score { get; set; }

		/// <summary>
		/// Date ofd the update.
		/// </summary>
		[JsonProperty(PropertyName = "date")]
		public DateTime? Date { get; set; }

		/// <summary>
		/// Status (reading, watching, completed, etc.)
		/// </summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }
	}
}