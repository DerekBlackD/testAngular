(function () {
    
    angular.module('Security')
    .factory('menuService', ['$http', '$q', function ($http, $q) {
        function all() {
            var deferred = $q.defer();
            //$http.get('/menuindex.json')
            //    .success(function (data) {
            //        deferred.resolve(data);
            //    });
            $http.get('/api/Menu')
                .success(function (data) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        }

        return {
            all: all
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