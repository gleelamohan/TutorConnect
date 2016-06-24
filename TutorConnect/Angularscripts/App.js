/// <reference path="E:\Users\Leela\Documents\Visual Studio 2013\Projects\TutorConnect\TutorConnect\templates/Home.html" />
var myApp = angular.module("myApp", ['ui.router']);

myApp.config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.when("", "home");

    $stateProvider
       .state("home", {
           url: "/home",
           templateUrl: "/templates/Home.html"
       })
       .state("profile", {
           url: "/profile",
           templateUrl: "/templates/TutorProfile.html"
       })
       .state("page3", {
           url: "/page3",
           templateUrl: "Page-3.html"
       });
});