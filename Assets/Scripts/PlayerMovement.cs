using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public struct Movement:IComponentData {
	public float WalkSpeed;
	public float RunSpeed;
}

public class PlayerMovementSystem:JobComponentSystem {

	[RequireComponentTag(typeof(Player))]
	struct WalkJob:IJobForEach<Movement, TranslationBody> {
		public float deltaTime;
		public float2 direction;
		public void Execute([ReadOnly] ref Movement m, ref TranslationBody t) {
			t.Position += direction * m.WalkSpeed * deltaTime;
		}
	}

	[RequireComponentTag(typeof(Player))]
	struct RunJob:IJobForEach<Movement, TranslationBody> {
		public float deltaTime;
		public float2 direction;
		public void Execute([ReadOnly] ref Movement m, ref TranslationBody t) {
			t.Position += direction * m.RunSpeed * deltaTime;
		}
	}

	Input.Actions inputs;

	protected override void OnCreate() {
		base.OnCreate();
		inputs = new Input.Actions();
		inputs.Movement.Move.performed += MovePerformed;
		inputs.Movement.Run.performed += RunPerformed;
	}

	protected override void OnStartRunning() {
		base.OnStartRunning();
		inputs.Enable();
	}

	protected override void OnStopRunning() {
		base.OnStopRunning();
		inputs.Disable();
	}

	protected override void OnDestroy() {
		base.OnDestroy();
		inputs.Movement.Move.performed -= MovePerformed;
		inputs.Movement.Run.performed -= RunPerformed;
	}

	bool run;
	void RunPerformed(InputAction.CallbackContext ctx) =>
		run = ctx.ReadValue<float>() != 0f;

	float2 direction;
	void MovePerformed(InputAction.CallbackContext ctx) =>
		direction = ctx.ReadValue<Vector2>();

	protected override JobHandle OnUpdate(JobHandle inputDeps) {
		return run ?
		new RunJob { deltaTime = Time.deltaTime, direction = direction }.Schedule(this, inputDeps) :
		new WalkJob { deltaTime = Time.deltaTime, direction = direction }.Schedule(this, inputDeps);
	}
}