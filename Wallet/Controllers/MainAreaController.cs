﻿using System;
using System.Threading;

namespace Wallet
{
	public class MainAreaController
	{
		private const int DEFAULT_MENU_TOP_IDX = 1;
		private const int DEFAULT_MENU_LEFT_IDX = 2;
		private static MainAreaController instance = null;

		private MainAreaView mainAreaView; 
		public MainAreaView MainAreaView { 
			set { 
				mainAreaView = value; mainAreaView.Page = DEFAULT_MENU_TOP_IDX; 
			} 
		}
	
		public TestTabsBarView TestTabsBarView { set { value.Default = DEFAULT_MENU_TOP_IDX; } }
		public TestTabsBarVertView TestTabsBarVertView { set { value.Default = DEFAULT_MENU_LEFT_IDX; } }

		public static MainAreaController GetInstance() {
			if (instance == null) {
				instance = new MainAreaController ();
			}

			return instance;
		}

		public MainAreaController()
		{
			EventBus.GetInstance ().Register ("button", delegate (String value) {
				switch (value) {
				case "Portfolio":
					mainAreaView.Page = 0;
					break;
				case "Wallet":
					mainAreaView.Page = 1;
					break;
				case "Contract":
					mainAreaView.Page = 2;
					break;
				}
				Console.Write(value);
			});
		}
	}
}
