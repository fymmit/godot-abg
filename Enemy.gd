extends CharacterBody2D

const SPEED = 150

func _init():
	velocity = Vector2.LEFT * SPEED

func _physics_process(delta):
	var collision = move_and_collide(velocity * delta)
	if collision:
		var collider = collision.get_collider()
		if collider.has_meta("type") && collider.get_meta("type") == "wall":
			velocity = velocity.bounce(collision.get_normal())
