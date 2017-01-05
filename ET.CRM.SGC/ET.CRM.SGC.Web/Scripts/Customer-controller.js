(function () {
    angular.module('Security')
    .controller('customerController', ['$scope', '$state', 'customerService', function ($scope, $state, customerService) {
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