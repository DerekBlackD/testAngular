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

            //modalInstance.result.then(function (selectedItem) {
            //    console.log('hola mundo');
            //});
        };

        $scope.closePlacesModal = function () {
            $scope.dismiss({ $value: 'cancel' });
        };

        $scope.loadMenu = function () {
            userService.getMenuByProfileID().then(function (data) {
                $scope.menu = data;
            });
        };

        $scope.validateUser = function () {
            $scope.payLoad = $auth.getPayload();
            //$scope.getUserByID($scope.payLoad.BusinessID, $scope.payLoad.ID).then(function () {
            //    console.log($scope.userData);
            //});

            userService.getUserByID($scope.payLoad.BusinessID, $scope.payLoad.ID).then(function (data) {
                $scope.userData = data;
                //console.log($scope.userData);
                if ($scope.userData.Profiles.length == 1) {
                    $scope.loadMenu();
                    $state.go("Collection");
                } else if ($scope.userData.Profiles.length > 1) {
                    $state.go("ChooseProfile");
                } else {
                    //$state.go("error");
                }
            });
            
        };

        $scope.getUserByID = function (BusinessID, ID) {
            userService.getUserByID(BusinessID, ID).then(function (data) {
                $scope.userData = data;
                //console.log($scope.userData);
            });
        }

        $scope.logOut = function () {
            $auth.logout()
            .then(function () {
                $rootScope.loadPrincipalControls = false;
                $state.go("Home");
            });
        };
        
    }])
    .controller('loginController', ['$rootScope', '$scope', '$state', '$auth', function ($rootScope, $scope, $state, $auth) {
        $scope.showMessage = false;
        $scope.Message = "";
        $scope.$parent.logOut();
        $scope.login = function () {
            $auth.login({
                username: $scope.login.UserName,
                password: $scope.login.Password
            })
            .then(function () {
                $rootScope.loadPrincipalControls = true;
                $scope.$parent.validateUser();
            })
            .catch(function (response) {
                $scope.showMessage = true;
                $scope.Message = response.data.error_description;
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