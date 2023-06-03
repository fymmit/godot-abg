extends CharacterBody2D

var speed = 150;

func get_input():
	var direction = Input.get_vector("ui_left", "ui_right", "ui_up", "ui_down");
	velocity = direction * speed;

func _physics_process(_delta):
	get_input();
	move_and_slide();
