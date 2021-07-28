app.controller("students",function($scope,$http,ajax){
    ajax.get("https://localhost:44387/api/Student/GetAll",success,error);
    function success(response){
      $scope.students=response.data;
    }
    function error(error){

    }

});
