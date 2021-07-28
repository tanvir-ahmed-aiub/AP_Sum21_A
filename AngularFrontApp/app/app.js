var app = angular.module("myApp", ["ngRoute"]);
var API_ROOT = "https://localhost:44387/";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/students", {
        templateUrl : "views/pages/students.html",
        controller: 'students'
    })
    .when("/addstudent", {
        templateUrl : "views/pages/addstudent.html",
        controller: 'addstudent'
    })
    .when("/adddepartment", {
        templateUrl : "views/pages/adddepartment.html",
        controller: 'adddepartment'
    })
    .when("/departments", {
        templateUrl : "views/pages/departments.html",
        controller: 'departments'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
