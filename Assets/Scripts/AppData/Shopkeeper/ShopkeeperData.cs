using System;
using UnityEngine;

namespace AppData.Shopkeeper
{
	[Serializable]
	public class ShopkeeperData : IShopkeeperData
	{
		 [field: SerializeField] public string Name { get; private set; }
	}
}