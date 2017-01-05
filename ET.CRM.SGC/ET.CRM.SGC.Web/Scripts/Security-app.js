(function () {
    var app = angular.module('Security', ['ui.router']);

    app.run(['$rootScope', function ($rootScope) {
        $rootScope.loadStates = {menuState : false, userState: false, homeState: false};
    }]);

    app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        //$locationProvider.hashPrefix('!').html5Mode(true);

        $urlRouterProvider.otherwise('/Home');

        $stateProvider
        .state('Home', {
            url: '/',
            templateUrl: '/Views/Login.html',
            controller: 'loginController'
        })
        .state('Collection', {
            url: '/Cobranza/Inicio',
            templateUrl: '/Views/Collection/Home.html'
        })
        .state('ColPhoneMngt', {
            url: '/Cobranza/GestionTelefonica',
            views: {
                '': { templateUrl: '/Views/Collection/PhoneManagement/IndexManagement.html' },
                'customerData@ColPhoneMngt': { templateUrl: '/Views/Collection/PhoneManagement/CustomerData.html', controller: 'customerController' },
                'phoneData@ColPhoneMngt': { templateUrl: '/Views/Collection/PhoneManagement/CustPhoneData.html'},
                'accountData@ColPhoneMngt': { templateUrl: '/Views/Collection/PhoneManagement/CustAccountData.html' },
                'managementData@ColPhoneMngt': { templateUrl: '/Views/Collection/PhoneManagement/CustManagementData.html' },
                'saveManagementData@ColPhoneMngt': { templateUrl: '/Views/Collection/PhoneManagement/SaveManagementData.html' }
            } 
        })
        .state('ColAddressMngt', {
            url: '/Cobranza/GestionCampo',
            templateUrl: 'Views/Collection/AddressManagement/IndexManagement.html'
        })
        .state('ColProgressiveMngt', {
            url: '/Cobranza/GestionProgresiva',
            templateUrl: 'Views/Collection/MaintenanceProgressive/IndexProgressive.html'
        })
        .state('ColCollectionAnalysis', {
            url: '/Cobranza/AnalisisRecaudacion',
            templateUrl: 'Views/Collection/CollectionAnalysis/IndexAnalysis.html'
        })
        .state('ColAssignment', {
            url: '/Cobranza/Asignacion',
            templateUrl: 'Views/Collection/Assignment/IndexAssignment.html'
        })
        .state('ColMaintenanceCustomer', {
            url: '/Cobranza/MantenimientoClientes',
            templateUrl: 'Views/Collection/MaintenanceCustomer/IndexCustomer.html'
        })
        /* ================== MANTENIMIENTO DE CLIENTES - CARTERA - INICIO ================== */
        .state('ColMaintenancePortfolioCustomer', {
            url: '/Cobranza/MantenimientoCartera',
            templateUrl: 'Views/Collection/MaintenancePortfolio/IndexPortfolioCustomer.html',
            controller: 'portfolioCustomerController'
        })
        .state('ColMaintenancePortfolioCustomerNew', {
            url: '/Cobranza/MantenimientoCartera/NuevoCliente',
            templateUrl: 'Views/Collection/MaintenancePortfolio/NewPortfolioCustomer.html',
            controller: 'portfolioCustomerController'
        })
        .state('ColMaintenancePortfolioCustomerEdit', {
            url: '/Cobranza/MantenimientoCartera/EditarCliente',
            templateUrl: 'Views/Collection/MaintenancePortfolio/EditPortfolioCustomer.html',
            controller: 'portfolioCustomerController'
        })
        .state('ColMaintenancePortfolioCustomerDelete', {
            url: '/Cobranza/MantenimientoCartera/EliminarCliente',
            templateUrl: 'Views/Collection/MaintenancePortfolio/DeletePortfolioCustomer.html',
            controller: 'portfolioCustomerController'
        })
        /* ================== MANTENIMIENTO DE CLIENTES - CARTERA - FIN ================== */
        .state('ColMaintenanceManager', {
            url: '/Cobranza/MantenimientoGestor',
            templateUrl: 'Views/Collection/MaintenanceManager/IndexManager.html'
        })
        .state('ColQueryCollection', {
            url: '/Cobranza/ConsultaRecaudacion',
            templateUrl: 'Views/Collection/CollectionAnalysis/IndexQuery.html'
        })
        .state('ColPortfolioReport', {
            url: '/Cobranza/ReporteCarteras',
            templateUrl: 'Views/Collection/PortfolioReport/IndexReport.html'
        })
        .state('ColQueryNotificaciones', {
            url: '/Cobranza/Notificaciones',
            templateUrl: 'Views/Collection/Notifications/IndexNotification.html'
        })
        .state('ColBulkUpload', {
            url: '/Cobranza/CargaMasiva',
            templateUrl: 'Views/Collection/BulkUpload/IndexBulk.html'
        })
        .state('ColGeneralConfig', {
            url: '/Cobranza/ConfiguracionGeneral',
            templateUrl: 'Views/Collection/GeneralConfiguration/IndexConfiguration.html'
        })
        .state('ColResultsConfig', {
            url: '/Cobranza/ResultadosGestion',
            templateUrl: 'Views/Collection/ResultsConfiguration/IndexResults.html'
        })
        .state('ColSearchers', {
            url: '/Cobranza/Buscadores',
            templateUrl: 'Views/Collection/SearcherOfData/Searchers.html'
        })
        .state('ColSecurityUser', {
            url: '/Cobranza/MantenimientoUsuarios',
            templateUrl: 'Views/Collection/MaintenanceUser/IndexUser.html'
        })
        .state('ColSecurityOption', {
            url: '/Cobranza/MantenimientoOpcion',
            templateUrl: 'Views/Collection/MaintenanceOption/IndexOption.html'
        });


        //.when('/', {
        //    templateUrl: '/Views/Login.html',
        //    controller: 'loginController'
        //})
        //.when('/Cobranza/Inicio', {
        //    templateUrl: '/Views/Collection/Home.html'
        //})
        //.when('/Cobranza/GestionTelefonica', {
        //    templateUrl: '/Views/Collection/PhoneManagement.html'
        //})
        //.otherwise({
        //    redirectTo: '/'
        //});
    }]);
})();