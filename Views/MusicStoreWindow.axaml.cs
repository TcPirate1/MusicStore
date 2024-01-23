using Avalonia.ReactiveUI;
using MusicStore.ViewModels;
using ReactiveUI;
using System;

namespace MusicStore
{
    public partial class MusicStoreWindow : ReactiveWindow<MusicStoreViewModel>
    {
        public MusicStoreWindow()
        {
            InitializeComponent();
            this.WhenActivated(action => action(ViewModel!.BuyMusicCommand.Subscribe(Close)));
        }
    }
}
