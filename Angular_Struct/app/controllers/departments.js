app.controller("departments",function($scope,ajax){
      function success(response){
          $scope.departments = response.data;
      }
      function failure (error){

      }
      ajax.get("https://localhost:44387/api/Department/GetAll",success,failure);
});
