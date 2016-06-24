myApp.controller('TutorProfile', function ($scope, $http) {

    $scope.TutorProfile = {
        FirstName: "Leela"
        ,MiddleName: "Mohan"
        ,LastName: "G"
        ,Email:"leelamohan.g@gmail.com"
        ,PhoneNo:"9042963126"
        ,Address:"vhjj hvhjj bjhjk"
        ,Gender:"0"
        ,Landmark:"vghchgcg"
        ,State:"0"
        ,City:"0"
        ,Area:"0"
        ,Pincode:"524137"
        ,Qualification:"B.Tech"
        ,Comments:"vhgfj  ugg kjhkj nhjkh"
    };


    $scope.SaveProfile = function() {
        
        var res = $http.post('http://localhost:1816/breeze/TutorProfile/InsertTutorDetails', $scope.TutorProfile);
        res.success(function (data, status, headers, config) {
            $scope.message = data;
        });
    };
});