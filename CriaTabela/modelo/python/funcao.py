from .models import #ltabela
from django.contrib import messages
from django.db.models import Sum
from io import StringIO, BytesIO
import datetime
import xlsxwriter
from decimal import *
import itertools
#import pdb; pdb.set_trace()

def GeraExcel(#ltabelas):
    output = BytesIO()
    workbook = xlsxwriter.Workbook(output)   

    # excel styles
    title = workbook.add_format({
        'bold': True,
        'font_size': 14,
        'align': 'center',
        'valign': 'vcenter'
    })
    header = workbook.add_format({
        'bold': True,
        'bg_color': '#337ca5',
        'color': 'white',
        'align': 'center',
        'valign': 'top',
        'border': 1
    })
    cell = workbook.add_format({
        'align': 'left',
        'valign': 'top',
        'text_wrap': True,
        'border': 1
    })
    cell_center = workbook.add_format({
        'align': 'center',
        'valign': 'top',
        'border': 1
    })
    cell_valor = workbook.add_format({
        'num_format': 'R$ #,##0.00;[Red]R$ #,##0.00',
        'valign': 'top',
        'border': 1
    })

    worksheet_s = workbook.add_worksheet('#utabelas')
    title_text = '#utabelas'

	# merge cells
    worksheet_s.merge_range('A2:F2', title_text, title)

    # write header
    #excelheader
    #worksheet_s.write(3, 0, "Pago?", header)
    #worksheet_s.write(3, 1, "Descrição", header)
    #worksheet_s.write(3, 2, "Categoria", header)
    #worksheet_s.write(3, 3, "Parcela", header)   
    #worksheet_s.write(3, 4, "Dt Vencimento", header)
    #worksheet_s.write(3, 5, "Valor(R$)", header)        

    row = 4

    for #ltabela in #ltabelas: 

        #excellinha
        #worksheet_s.write(row, 0, str('Sim' if #ltabela.pago is True else 'Não'), cell)
        #worksheet_s.write_string(row, 1, #ltabela.descricao, cell)
        #worksheet_s.write_string(row, 2, #ltabela.#ltabela.descricao, cell)
        #worksheet_s.write_string(row, 3, #ltabela.parcela, cell)
        #worksheet_s.write_string(row, 4, #ltabela.dt_vencimento.strftime('%d/%m/%Y'), cell_center)
        #worksheet_s.write_number(row, 5, Decimal(#ltabela.valor or 0), cell_valor)
                
        # change column widths
        worksheet_s.set_column('A:A', 15)  
        worksheet_s.set_column('B:B', 15)  
        worksheet_s.set_column('C:C', 15)          
        worksheet_s.set_column('D:D', 15)  
        worksheet_s.set_column('E:E', 15)  
        worksheet_s.set_column('F:F', 15)      

        row = row + 1

    # close workbook
    workbook.close()
    xlsx_data = output.getvalue()
    return xlsx_data