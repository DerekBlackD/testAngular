(function () {
    angular.module('Security')
    .controller('customerController', ['$scope', '$state', 'customerService', 'generalConfigService', function ($scope, $state, customerService, generalConfigService) {
        $scope.StateFormPhone = true;
        $scope.newCustomerPhone = function () {
            $scope.StateFormPhone = false;
        };
        $scope.editCustomerPhone = function () {
            $scope.StateFormPhone = false;
        };
        $scope.saveCustomerPhone = function () {
            $scope.StateFormPhone = true;
        };
        $scope.cancelCustomerPhone = function () {
            $scope.StateFormPhone = true;
        };
        generalConfigService.getGeneralSelect('1', '1').then(function (data) {
            $scope.ProviderPhone = data;
        });
        generalConfigService.getGeneralSelect('1', '2').then(function (data) {
            $scope.OriginPhone = data;
        });
        customerService.getCustomer().then(function (data) {
            $scope.customerData = data;
        });
    }])
    .factory('customerService', ['$http', '$q', function ($http, $q) {
        function getCustomer() {
            var deferred = $q.defer();
            $http.get('/api/Customer')
               .success(function (data) {
                   deferred.resolve(data);
               });
            return deferred.promise;
        }
        return {
            getCustomer: getCustomer
        };
    }]);
})();