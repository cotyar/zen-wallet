﻿using NUnit.Framework;
using System;
using System.Linq;
using Infrastructure;

namespace Zen
{
	[TestFixture()]
	public class Tests
	{
		[Test()]
		public void CanAquireGenesisOutputs()
		{
			App app = new App();

			app.Settings.Mode = Settings.AppModeEnum.GUI;
			app.Init();

			app.AddGenesisBlock();

			JsonLoader<Outputs>.Instance.Value.Values.ForEach(o => app.AddKey(o.Key));

			app.ImportWallet();

			app.Start();
		}
	}
}
