# MusicStore
Following the music store app on Avalonia.

Have gotten VS code extension to preview properly. It was because I did not have the .NET 7.0 SDK installed.

Attempt to run this in Linux partition as that's where the .NET 7.0 SDK is installed, the repo in GitHub is targetting this version.

## Notes
https://docs.avaloniaui.net/docs/tutorials/music-store-app/add-content-to-dialog (Diagram of layout of the music store)

https://www.reactiveui.net/docs/handbook/view-models/ (Goes into RaiseAndSetIfChanged, basically is used to detect change, not doing anything with those detections)

https://docs.avaloniaui.net/docs/0.10.x/data-binding/change-notifications#collection-changes (More options for detecting changes)

https://docs.avaloniaui.net/docs/tutorials/music-store-app/mock-search (Uses `ObservableCollection`, a way to detect changes)

https://github.com/AvaloniaUI/Avalonia/discussions/13035, https://www.reddit.com/r/csharp/comments/ijlkx4/every_initializecomponent_reference_in_my_project/ (Fixed by simply building the project.)

https://github.com/AvaloniaUI/MusicStoreTutorial/tree/master/Avalonia.MusicStore (There are differences between the tutorial and the repo code. Repo code works while simply following tutorial does not.)