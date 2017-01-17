(function () {
    'use strict';
    angular.module('Security')
    .controller('principalController', ['$rootScope', '$scope', '$auth', '$state', '$uibModal', 'userService', function ($rootScope, $scope, $auth, $state, $uibModal, userService) {
        $scope.menu = {};
        $scope.userData = {};

        $scope.openPlacesModal = function (size) {
            var modalInstance = $uibModal.open({
                animation: true,
                ariaLabelledBy: 'modal-title',
                ariaDescribedBy: 'modal-body',
                templateUrl: '/myModalContent.html',
                controller: 'principalController',
                size: size
            });


            modalInstance.result.then(function (selectedItem) {
                console.log('hola mundo');
            });
        };

        $scope.closePlacesModal = function () {
            $scope.dismiss({ $value: 'cancel' });
        };

        $scope.loadMenu = function () {
            userService.getMenuByProfileID().then(function (data) {
                $scope.menu = data;
            });
        };

        $scope.getUserByID = function (BusinessID, ID) {
            userService.getUserByID(BusinessID, ID).then(function (data) {
                $scope.userData = data;
            });
        }

        $scope.logOut = function () {
            $auth.logout()
            .then(function () {
                $rootScope.loadStates.menuState = !$rootScope.loadStates.menuState;
                $rootScope.loadStates.userState = !$rootScope.loadStates.userState;
                $rootScope.loadStates.homeState = !$rootScope.loadStates.homeState;
                $state.go("Home");
            });
        };
        
    }])
    .controller('loginController', ['$rootScope', '$scope', '$state', '$auth', function ($rootScope, $scope, $state, $auth) {

        $auth.logout()
            .then(function () {
                $rootScope.loadStates.menuState = false
                $rootScope.loadStates.userState = false
                $rootScope.loadStates.homeState = false
                $state.go("Home");
            });

        $scope.login = function () {
            $auth.login({
                username: $scope.login.UserName,
                password: $scope.login.Password
            })
            .then(function () {
                $rootScope.loadStates.menuState = !$rootScope.loadStates.menuState;
                $rootScope.loadStates.userState = !$rootScope.loadStates.userState;
                $rootScope.loadStates.homeState = !$rootScope.loadStates.homeState;
                $scope.payLoad = $auth.getPayload();
                console.log($scope.payLoad.BusinessID);
                console.log($scope.payLoad.ID);
                $scope.$parent.loadMenu();
                $state.go("Collection");
            })
            .catch(function (response) {
                console.log(response.data.error_description);
            });

        };

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