app.controller("addstudent",function($scope,ajax,$location){

  ajax.get(API_ROOT+"api/Department/GetAll",
  function(resp){
    $scope.departments = resp.data;
  },
  function(err){

  });

  $scope.addstudent = function(s){
     ajax.post(API_ROOT+"api/Student/Add",s,
     function(resp){
          $location.path("/students");
     },function(err){});

  };
});
