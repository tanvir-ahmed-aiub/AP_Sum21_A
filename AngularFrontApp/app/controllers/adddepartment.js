app.controller("adddepartment",function($scope,ajax){

    $scope.adddepartment = function(){
        //$scope.Name
        var d = {
          Id:0,
          Name:$scope.Name
        };
        ajax.post(API_ROOT+"api/Department/Add",d,
        function(response){

        },
        function(err){

        });
    };
});
