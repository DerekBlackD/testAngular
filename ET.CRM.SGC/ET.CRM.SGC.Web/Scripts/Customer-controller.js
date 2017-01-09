(function () {
    angular.module('Security')
    .controller('customerPhoneController', ['$scope', '$state', 'customerService', 'generalConfigService', function ($scope, $state, customerService, generalConfigService) {
        $scope.StateFormPhone = true;
        $scope.FormType = 1;
        $scope.editData = {};
        $scope.customerData = {};
        $scope.customerData.Phones = {};
        $scope.newCustomerPhone = function () {
            $scope.StateFormPhone = false;
            $scope.FormType = 2;
        };
        $scope.editCustomerPhone = function (PhoneID) {
            $scope.StateFormPhone = false;
            $scope.FormType = 3;
            customerService.getCustomerPhone(PhoneID).then(function (data) {
                $scope.editData = data;
            });
        };
        $scope.saveCustomerPhone = function () {
            $scope.customerData.Phones = {};
            if ($scope.FormType == 2) {
                customerService.insertCustomerPhone($scope.editData).then(function (data) {
                    $scope.loadCustomerPhone();
                });
            } else {
                customerService.updateCustomerPhone($scope.editData).then(function (data) {
                    $scope.loadCustomerPhone();
                });
            }
            
            $scope.FormType = 1;
            $scope.StateFormPhone = true;
        };
        $scope.cancelCustomerPhone = function () {
            $scope.FormType = 1;
            $scope.StateFormPhone = true;
        };
        
        $scope.loadCustomerPhone = function () {
            customerService.getAllCustomerPhone().then(function (data) {
                $scope.customerData.Phones = data;
            });
        };
        //customerService.getAllCustomerPhone().then(function (data) {
        //    $scope.customerData.Phones = data;
        //});
        //Start - Load Select Objects
        generalConfigService.getGeneralSelect('1', '1').then(function (data) {
            $scope.ProviderPhone = data;
        });
        generalConfigService.getGeneralSelect('1', '2').then(function (data) {
            $scope.OriginPhone = data;
        });
        //End - Load Select Objects
    }])
    .controller('customerController', ['$scope', '$state', 'customerService', function ($scope, $state, customerService ) {
        customerService.getCustomer().then(function (data) {
            $scope.customerData = data;
            //customerPhoneController.loadCustomerPhone();
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

        function getAllCustomerPhone() {
            var deferred = $q.defer();
            $http.get('/api/CustomerPhone/')
               .success(function (data) {
                   deferred.resolve(data);
               });
            return deferred.promise;
        }

        function getCustomerPhone(idPhone) {
            var deferred = $q.defer();
            $http.get('/api/CustomerPhone/' + idPhone)
               .success(function (data) {
                   deferred.resolve(data);
               });
            return deferred.promise;
        }

        function insertCustomerPhone(oCustomerPhone) {
            var deferred = $q.defer();
            var id = oCustomerPhone.ID;
            $http.post('/api/CustomerPhone/',
                JSON.stringify(oCustomerPhone), {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                })
               .success(function (data) {
                   deferred.resolve(data);
               });
            return deferred.promise;
        }

        function updateCustomerPhone(oCustomerPhone) {
            var deferred = $q.defer();
            var id = oCustomerPhone.ID;
            $http.put('/api/CustomerPhone/' + id,
                JSON.stringify(oCustomerPhone), {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                })
               .success(function (data) {
                   deferred.resolve(data);
               });
            return deferred.promise;
        }
        return {
            getCustomer: getCustomer, // Get all information of customer
            getAllCustomerPhone: getAllCustomerPhone, // Get all customer phones
            getCustomerPhone: getCustomerPhone, // Get a phone data of customer
            insertCustomerPhone: insertCustomerPhone,
            updateCustomerPhone: updateCustomerPhone
        };
    }]);
})();