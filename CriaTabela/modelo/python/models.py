from django.db import models
from django.contrib.auth.models import User

# Create your models here.
class #utabela(models.Model):
    #camposmodels
    usuario         = models.ForeignKey(User, on_delete=models.CASCADE, null=True)    
    """
    def __str__(self):
        return self.descricao
    """