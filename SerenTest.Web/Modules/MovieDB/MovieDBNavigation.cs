﻿using Serenity.Navigation;
using MyPages = SerenTest.MovieDB.Pages;

[assembly: NavigationMenu(int.MaxValue, "MovieDB",icon: "fa-film")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie", 
    typeof(MyPages.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Genre", typeof(MyPages.GenreController), icon: "fa-thumb-tack")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie Genres", typeof(MyPages.MovieGenresController), icon: null)]