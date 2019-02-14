from django.shortcuts import render, redirect, get_object_or_404, HttpResponse
from .models import (
	#ltabela,
	)
from .forms import (
	#ltabelaFormView,	
	)
from django.utils import timezone
from django.contrib import messages
from django.core import serializers
from .funcao import (	
	GeraExcel
	)
import datetime
import calendar
import json


#import pdb; pdb.set_trace()

def #utabela_Add(request):
	if request.is_ajax():
		if request.method == 'POST':
			form = #utabelaFormView(request.POST)
			if form.is_valid():
				#ltabela = form.save(commit=False)           	
				#ltabela.usuario = request.user
				#ltabela.save()
				retorno_dict = {'chave': #ltabela.pk, 'descricao': #ltabela.descricao}				
			else:
				retorno_dict = {'chave': 'erro', 'descricao': str(form.errors)}

			retorno = json.dumps(retorno_dict)
			return HttpResponse(retorno)
		
	else:	
		if request.method == 'POST':
			form = #utabelaFormView(request.POST)
			if form.is_valid():
				#ltabela = form.save(commit=False)           	
				#ltabela.usuario = request.user
				#ltabela.save()
				return redirect('#appname:#ltabela_list')
		else:
			form = #utabelaFormView()

		args = {'form': form}

		return render(request, '#appname/#ltabela_add.html', args)

def #utabela_List(request):	
	#ltabelas = #utabela.objects.filter(usuario=request.user)	
	args = {'#ltabelas': #ltabelas}
	return render(request, '#appname/#ltabela_list.html', args)

def #utabela_View(request, pk):
	#ltabela = get_object_or_404(#utabela, pk=pk)
	if #ltabela.usuario != request.user:
		messages.error(request, "Acesso negado!", extra_tags='alert-error alert-dismissible')			
		return redirect('#appname:#ltabela_list')

	args = {'#ltabela': #ltabela}
	return render(request, '#appname/#ltabela_view.html', args)

def #utabela_Edit(request, pk):
	#ltabela = get_object_or_404(#utabela, pk=pk)
	if #ltabela.usuario != request.user:
		messages.error(request, "Acesso negado!", extra_tags='alert-error alert-dismissible')			
		return redirect('#appname:#ltabela_list')
	if request.method == 'POST':
		form = #utabelaFormView(request.POST, instance=#ltabela)        
		if form.is_valid():  			
			form.save()            
			messages.success(request, "Informações atualizadas com sucesso.", extra_tags='alert-success alert-dismissible')
			
			return redirect('#appname:#ltabela_list')
		else:
			messages.error(request, "Foram preenchidos dados incorretamente.", extra_tags='alert-error alert-dismissible')               
	else:
		form = #utabelaFormView(instance=#ltabela)        

	args = {'form': form}    

	return render(request, '#appname/#ltabela_edit.html', args)

def #utabela_Del(request):
    if request.POST and request.is_ajax():        
        if request.POST.getlist('#ltabela_lista[]'):
            #ltabela_list = request.POST.getlist('#ltabela_lista[]')            
            for i in #ltabela_list:
                #ltabela = #utabela.objects.get(pk=i)
                if #ltabela.usuario != request.user:
                    messages.error(request, "Acesso negado!", extra_tags='alert-error alert-dismissible')			
                    return redirect('#appname:#ltabela_list')
                #ltabela.delete()            
            messages.success(request, "Mensagens excluidas com sucesso.", extra_tags='alert-success alert-dismissible')            
        else:
            messages.error(request, "Nenhuma mensagem selecionada.", extra_tags='alert-error alert-dismissible')               

    return HttpResponse('')

def Gera_XLS_Mes(request):
	"""
	p_data_ini    = request.GET.get('data_ini')
	p_data_fim    = request.GET.get('data_fim')

	try:		
		data_ini = datetime.datetime(int(p_data_ini[:4]), int(p_data_ini[5:7]), int(p_data_ini[8:10]))
		data_fim = datetime.datetime(int(p_data_fim[:4]), int(p_data_fim[5:7]), int(p_data_fim[8:10]))
	except:
		messages.error(request, "Data inválida.", extra_tags='alert-error alert-dismissible')    
		return redirect('#appname:#ltabelas')	
	"""

	#ltabelas = #utabela.objects.all()

	#time.sleep(3)

	response = HttpResponse(content_type='application/vnd.ms-excel')
	#response['Set-Cookie'] = "fileDownload=true; path=/"
	response['Content-Disposition'] = 'attachment; filename=#ltabelas.xlsx'

	xlsx_data = GeraExcel(#ltabelas)
	response.write(xlsx_data)
	return response
