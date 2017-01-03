(function () {
    'use strict';
    angular.module('Security')
    .controller('loginController', ['$rootScope', '$scope', '$state', function ($rootScope, $scope, $state) {
        $scope.login = function () {
            $rootScope.loadStates.menuState = true;
            $rootScope.loadStates.userState = true;
            $rootScope.loadStates.homeState = true;
            //$location.path('/Cobranza/Inicio');
            $state.go("Collection");
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