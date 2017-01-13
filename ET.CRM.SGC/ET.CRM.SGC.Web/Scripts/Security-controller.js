(function () {
    'use strict';
    angular.module('Security')
    .controller('loginController', ['$rootScope', '$scope', '$state', '$auth', function ($rootScope, $scope, $state, $auth) {
        $scope.login = function () {
            $rootScope.loadStates.menuState = true;
            $rootScope.loadStates.userState = true;
            $rootScope.loadStates.homeState = true;
            
            $auth.login({
                grant_type: "password",
                username: $scope.UserName,
                password: $scope.Password
            })
            .then(function () {
                $state.go("Collection");
            })
            .catch(function (response) {
                console.log("Error de autenticación");
            });

        };
    }])
    .controller('menuController', ['$scope', 'menuService', function ($scope, menuService) {
        menuService.all().then(function (data) {
            $scope.menu = data;
        });
    }])
    .controller('portfolioCustomerController', ['$scope', '$state', function ($scope, $state) {
        $scope.tab = 1;
        $scope.selectTab = function (tabSel) {
            $scope.tab = tabSel;
        };
        $scope.addPortfolioCustomer = function () {
            $state.go("ColMaintenancePortfolioCustomerNew");
        };
        $scope.editPortfolioCustomer = function () {
            $state.go("ColMaintenancePortfolioCustomerEdit");
        };
        $scope.deletePortfolioCustomer = function () {
            $state.go("ColMaintenancePortfolioCustomerDelete");
        };
        $scope.indexPortfolioCustomer = function () {
            $state.go("ColMaintenancePortfolioCustomer");
        };
    }]);
})();