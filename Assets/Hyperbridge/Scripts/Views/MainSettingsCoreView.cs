﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Hyperbridge.Wallet;
public class MainSettingsCoreView : MonoBehaviour {

    public InputField walletPathDisplay;

    void Start () {

        CodeControl.Message.AddListener<WalletPathChangedEvent>(OnWalletPathChanged);

    }
	

    void OnWalletPathChanged(WalletPathChangedEvent e)
    {
        walletPathDisplay.text = e.path;
    }



}
