module app.page8 {
    'use strict';
    class Page8Controller {
        static $inject = ['app.services.navigation'];
        constructor(nav: app.services.INavigationService) {
            nav.setCurrentStep(8);
            var vm = this;
        }
    }

    angular.module('app.page8').controller('app.page8.Controller', Page8Controller);
}   