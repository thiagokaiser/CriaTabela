from django import forms
from django.forms.widgets import TextInput
from .models import #utabela

class #utabelaFormView(forms.ModelForm):    
    class Meta:
        model = #utabela
        fields = (
                  #camposforms                  
        		)
        widgets = {
            #'dt_vencimento': TextInput(attrs={'type': 'date'}),
        }    