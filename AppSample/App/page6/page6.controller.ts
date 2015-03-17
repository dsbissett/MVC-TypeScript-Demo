module app.page6 {
    'use strict';
    class Page6Controller {
        static $inject = ['app.services.navigation'];
        constructor(nav: app.services.INavigationService) {
            nav.setCurrentStep(6);
            var vm = this;
        }
    }

    angular.module('app.page6').controller('app.page6.Controller', Page6Controller);
}   