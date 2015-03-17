module app.page7 {
    'use strict';
    class Page7Controller {
        static $inject = ['app.services.navigation'];
        constructor(nav: app.services.INavigationService) {
            nav.setCurrentStep(7);
            var vm = this;
        }
    }

    angular.module('app.page7').controller('app.page7.Controller', Page7Controller);
}   