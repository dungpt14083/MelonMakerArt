using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SList<T>
{
	[SerializeField]
	private List<T> values;

	public List<T> List
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SList(List<T> values)
	{
	}
}
