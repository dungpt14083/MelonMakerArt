using System;
using UnityEngine;

[Serializable]
public class Period
{
	[Range(1f, 12f)]
	public int month;

	[Range(1f, 31f)]
	public int day;

	public Period()
	{
	}

	public Period(int m, int d)
	{
	}

	public Period(DateTime date)
	{
	}

	public static bool operator <(Period left, Period right)
	{
		return false;
	}

	public static bool operator >(Period left, Period right)
	{
		return false;
	}

	public static bool operator <=(Period left, Period right)
	{
		return false;
	}

	public static bool operator >=(Period left, Period right)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
