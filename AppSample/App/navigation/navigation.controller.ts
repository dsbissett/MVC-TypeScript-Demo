module app.navigation {
    'use strict';

    interface INavigationScope {
        nav: app.services.INavigationService;
    }

    class NavigationController implements INavigationScope {
        nav: app.services.INavigationService;
        static $inject = ['app.services.navigation'];
        constructor(nav: app.services.INavigationService) {
            this.nav = nav;
        }

        next(): void {
            this.nav.next();
        }

        previous(): void {
            this.nav.previous();
        }

        current(): number {
            return this.nav.current();
        }

        jump(step: number): void {
            this.nav.jump(step);
        }

        setCurrentStep(step: number): void {
            this.nav.setCurrentStep(step);
        }
    }

    angular.module('app.navigation').controller('app.navigation.Controller', NavigationController);
}