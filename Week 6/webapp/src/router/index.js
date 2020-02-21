import Vue from 'vue';
import Router from 'vue-router';
import Home from '@/components/Home';
import students from '@/components/Students';
import instructors from '@/components/Instructors';

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: Home
    },
    {
      path: '/home',
      component: Home
    },
    {
      path: '/Students',
      component: Students
    },
    {
      path: '/Instructors',
      component: Instructors
    }
  ]
})
