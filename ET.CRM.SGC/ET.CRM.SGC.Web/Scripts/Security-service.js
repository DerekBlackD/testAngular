(function () {
    
    angular.module('Security')
    .factory('menuService', ['$http', '$q', function ($http, $q) {
        function all() {
            var deferred = $q.defer();

            $http.get('/menuindex.json')
                .success(function (data) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        }

        return {
            all: all
        };
    }]);
})();