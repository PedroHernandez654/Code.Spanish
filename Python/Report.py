def report():
    report_open = open('grades.json')
    report_read = report_open.read()
    report_open.close()

    report = json.loads(report_read)

    students_open = open('students.json', 'r')
    students_read = students_open.read()
    students_open.close()

    students = json.loads(students_read)

    subjects_open = open('subject.json', 'r')
    subjects_read = subjects_open.read()
    subjects_open.close()

    subjects = json.loads(subjects_read)

    Window = Tk()
    width = 400  # ancho
    high = 400  # alto  #Le pasamos los datos del tamaño
    x_ventana = Window.winfo_screenwidth() // 2 - width // 2  # Centrar ventana
    y_ventana = Window.winfo_screenheight() // 2 - high // 2
    posicion = str(width) + "x" + str(high) + "+" + str(x_ventana) + "+" + str(y_ventana)
    Window.geometry(posicion)
    Window.resizable(0, 0)
    Window.title('Reprobados')
    Window.config(bg='#FFFFFF')

    list = Listbox(Window)  # Creamos una lista arriba de la ventana
    list.place(relx=0.01, rely=0.01, relwidth=0.8, relheight=0.8)  # Le pasamos sus parametros

    Bar = Scrollbar(Window, command=list.yview)  # Le ponemos una barra para que se mueva de arriba a abajo
    Bar.place(relx=0.85, rely=0.3, relheight=0.5, relwidth=0.1)  # Le pasamos sus parametros
    list.config(yscrollcommand=Bar)  # Juntamos la barra con la lista

    for i in range(0, len(report) - 1):
        if report[i]['grade'] != -1:
            if report[i]['grade'] < 60:
                li1 =[f'Id: {report[i]["student_id"]}']
                li2 =[f'Id Materia: {report[i]["subject_id"]}']
    for x in range(0, len(students) -1):

        pass
    for j in range(0, len(subjects) - 1):
        pass
