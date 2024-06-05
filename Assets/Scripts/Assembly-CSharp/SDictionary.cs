using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[SerializeField]
	private List<TKey> keys;

	[SerializeField]
	private List<TValue> values;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
