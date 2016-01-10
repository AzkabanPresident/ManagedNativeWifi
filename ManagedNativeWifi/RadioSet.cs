﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedNativeWifi
{
	/// <summary>
	/// Radio information
	/// </summary>
	public class RadioSet
	{
		/// <summary>
		/// 802.11 PHY and media type
		/// </summary>
		public PhyType Type { get; }

		/// <summary>
		/// Whether software radio state is on
		/// </summary>
		public bool? SoftwareOn { get; }

		/// <summary>
		/// Whether hardware radio state is on
		/// </summary>
		public bool? HardwareOn { get; }

		/// <summary>
		/// Whether the radio is on
		/// </summary>
		public bool? On => (HardwareOn.HasValue && SoftwareOn.HasValue)
			? HardwareOn.Value && SoftwareOn.Value
			: (bool?)null;

		/// <summary>
		/// Constructor
		/// </summary>
		public RadioSet(PhyType type, bool? softwareOn, bool? hardwareOn)
		{
			this.Type = type;
			this.SoftwareOn = softwareOn;
			this.HardwareOn = hardwareOn;
		}
	}
}