from django.conf.urls import url
from . import views

app_name = '#appname'
urlpatterns = [    	
    url(r'^gera_xls_#ltabela/$', views.Gera_XLS_#utabela, name='gera_xls_#ltabela'),
    url(r'^#ltabela_add/$', views.#utabela_Add, name='#ltabela_add'),        
    url(r'^#ltabela_list/$', views.#utabela_List, name='#ltabela_list'),        
    url(r'^#ltabela_view/(?P<pk>\d+)/$', views.#utabela_View, name='#ltabela_view'),        
    url(r'^#ltabela_edit/(?P<pk>\d+)/$', views.#utabela_Edit, name='#ltabela_edit'),        
    url(r'^#ltabela_del/$', views.#utabela_Del, name='#ltabela_del'),
]