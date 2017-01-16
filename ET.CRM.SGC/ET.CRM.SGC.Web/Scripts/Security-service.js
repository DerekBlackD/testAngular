(function () {
    
    angular.module('Security')
    .factory('userService', ['$http', '$q', function ($http, $q) {
        function getMenuByProfileID() {
            var deferred = $q.defer();
            $http.get('/api/Menu')
                .success(function (data) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        }

        function getUserByID(BusinessID, ID) {
            var deferred = $q.defer();
            $http.get('/api/User/' + BusinessID + '/' + ID)
                .success(function (data) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        }

        return {
            getMenuByProfileID: getMenuByProfileID,
            getUserByID: getUserByID
        };
    }])
    .factory('generalConfigService', ['$http', '$q', function ($http, $q) {
        function getGeneralSelect(moduleID, optionID) {
            var deferred = $q.defer();
            $http.get('/api/GeneralSelect', { params: { intModuleID: moduleID, intOptionID: optionID } })
            .success(function (data) {
                deferred.resolve(data);
            });
            return deferred.promise;
        }

        return {
            getGeneralSelect: getGeneralSelect
        };
    }]);
})();