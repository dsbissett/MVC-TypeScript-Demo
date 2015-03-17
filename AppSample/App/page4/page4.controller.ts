module app.page4 {
    'use strict';
    class Page4Controller {
        static $inject = ['app.services.navigation'];
        constructor(nav: app.services.INavigationService) {
            nav.setCurrentStep(4);  
            var vm = this;
        }
    }

    angular.module('app.page4').controller('app.page4.Controller', Page4Controller);
}  