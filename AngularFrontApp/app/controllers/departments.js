app.controller("departments",function($scope,ajax){
    ajax.get(API_ROOT+"api/Department/Names",function(response){
      $scope.departments = response.data;
    },
    function(error){

    });
});
