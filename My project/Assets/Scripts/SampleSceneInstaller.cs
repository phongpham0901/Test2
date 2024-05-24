using GameFoundation.Scripts.UIModule.ScreenFlow.Managers;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SampleSceneInstaller : BaseSceneInstaller
{
    public override void InstallBindings()
    {
        base.InstallBindings();
        this.Container.InitScreenManually<LoadingScreenPresenter>();
    }
}
