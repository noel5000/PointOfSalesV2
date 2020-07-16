import { NbMenuItem } from '@nebular/theme';

export const MENU_ITEMS: NbMenuItem[] = [
  {
    title: 'dashboard_menu',
    icon: 'home-outline',
    link: '/pages/dashboard',
    home: true,
  },
  {
    title: 'FEATURES',
    group: true,
  },
  {
    title: 'auth_menu',
    icon: 'lock-outline',
    children: [
      {
        title: 'login__menu',
        link: '/auth/login',
      },
      {
        title: 'register_menu',
        link: '/auth/register',
      },
      {
        title: 'requestPass_menu',
        link: '/auth/request-password',
      },
      {
        title: 'resetPass_menu',
        link: '/auth/reset-password',
      },
    ],
  },
];
