(function () {
    'use strict';
    angular.module('Security')
    .controller('principalController', ['$rootScope', '$scope', '$auth', '$state', '$uibModal', '$window', 'userService', function ($rootScope, $scope, $auth, $state, $uibModal, $window, userService) {
        $scope.menu = {};
        $scope.guserData = {}; /* Global user data */
        $scope.gprofile = {}; /* Global profile */

        if ($window.sessionStorage.getItem("userData")) {
            $scope.guserData = JSON.parse($window.sessionStorage.getItem("userData"));
            $scope.gprofile = JSON.parse($window.sessionStorage.getItem("profileData"));
        };

        if ($auth.isAuthenticated()) {
            $rootScope.loadPrincipalControls = true;
        };

        $scope.openPlacesModal = function (size) {
            var modalInstance = $uibModal.open({
                animation: true,
                ariaLabelledBy: 'modal-title',
                ariaDescribedBy: 'modal-body',
                templateUrl: '/myModalContent.html',
                controller: 'principalController',
                size: size
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

        $scope.validateUser = function () {
            $scope.payLoad = $auth.getPayload();

            userService.getUserByID($scope.payLoad.BusinessID, $scope.payLoad.ID).then(function (data) {
                $scope.guserData = data;
                $window.sessionStorage.setItem("userData", JSON.stringify($scope.guserData));
                if ($scope.guserData.Profiles.length == 1) {
                    $scope.gprofile.ID = $scope.guserData.Profiles[0].ID;
                    $scope.gprofile.Description = $scope.guserData.Profiles[0].Description;
                    $window.sessionStorage.setItem("profileData", JSON.stringify($scope.gprofile));
                    $scope.loadMenu();
                    $state.go("Collection");
                } else if ($scope.guserData.Profiles.length > 1) {
                    $state.go("ChooseProfile");
                } else {
                    //$state.go("error");
                }
            });
            
        };

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
    .controller('chooseProfileController', ['$rootScope', '$scope', '$state', '$window', function ($rootScope, $scope, $state, $window) {
        $scope.dataProfiles = $scope.$parent.guserData.Profiles;
        $scope.oProfile = $scope.dataProfiles[0];

        $scope.f_ToEnter = function () {
            $scope.$parent.gprofile.ID = $scope.oProfile.ID;
            $scope.$parent.gprofile.Description = $scope.oProfile.Description;
            $window.sessionStorage.setItem("profileData", JSON.stringify($scope.$parent.gprofile));
            $scope.$parent.loadMenu();
            $state.go("Collection");
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