var MenuController = function ($scope) {
    $scope.Title = {
        Description: 'App Web'
    };
    $scope.MenuOptions = {
        Option1 : {
            Description: 'Option 1',
            Url : '/#/optionOne'
        },
        Option2 : {
            Description: 'Option 2',
            Url : '/#/optionTwo'
        },        
        Option3 : {
            Description: 'Option 3',
            Url : '/#/optionThree'
        },
    };
}

MenuController.$inject = ['$scope'];
