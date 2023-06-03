extends CharacterBody2D

signal kill

var speed = 150

func get_input():
	var direction = Input.get_vector("ui_left", "ui_right", "ui_up", "ui_down")
	velocity = direction * speed

func _physics_process(delta):
	get_input()
	var collision = move_and_collide(velocity * delta)
	if collision:
		if collision.get_collider().name == "Enemy":
			kill.emit()

func _on_kill():
	print("you are kill")
