﻿using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using MusicLyricApp.Models;

namespace MusicLyricApp.ViewModels;

public partial class SearchResultViewModel : ViewModelBase
{
    // 歌曲信息属性
    [ObservableProperty] private string _singer;

    [ObservableProperty] private string _songName;

    [ObservableProperty] private string _album;
    
    [ObservableProperty] private string _consoleOutput;
    
    [ObservableProperty] private Dictionary<string, SaveVo> _saveVoMap = new();

    public void ResetConsoleOutput(string consoleOutput)
    {
        Singer = "";
        SongName = "";
        Album = "";
        ConsoleOutput = consoleOutput;
    }
}