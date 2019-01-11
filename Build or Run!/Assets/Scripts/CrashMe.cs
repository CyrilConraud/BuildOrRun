using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class CrashMe : MonoBehaviour {

    [DllImport("kernel32.dll")]
    static extern void RaiseException(uint dwExceptionCode, uint dwExceptionFlags, uint n, IntPtr lp);

	// Use this for initialization
	void Start () {
        RaiseException(13, 0, 0, new IntPtr(1));
	}
}
