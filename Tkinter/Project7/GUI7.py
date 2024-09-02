import tkinter as tk
from tkinter import ttk
from datetime import datetime

def get_pos(event):
    print(f"x: {event.x}, y: {event.y}")

window = tk.Tk()
window.geometry("800x600")
window.title("Event binding")

text = tk.Text(master = window)
text.pack()
entry = ttk.Entry(master = window)
entry.pack()
button = ttk.Button(master = window, text = "butão")
button.pack()

# event
button.bind("<Alt-KeyPress-a>", lambda event: print(event))

# text.bind("<Motion>", get_pos)

# window.bind("<KeyPress>", lambda event: print(f"Button pressed: {event.keycode}, time: {datetime.now().strftime("%H:%M:%S.%f")[:-3]}"))

entry.bind("<FocusIn>", lambda event: print("Entry field was selected"))

text.bind("<Shift-MouseWheel>", lambda event: print("MouseWheel"))


window.mainloop()