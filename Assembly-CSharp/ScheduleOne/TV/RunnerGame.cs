using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x0200029C RID: 668
	public class RunnerGame : TVApp
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x0003DE54 File Offset: 0x0003C054
		protected override void Awake()
		{
			base.Awake();
			this.defaultCharacterY = this.Character.anchoredPosition.y;
			this.CloudSpawner.OnSpawn.AddListener(new UnityAction<GameObject>(this.CloudSpawned));
			this.ObstacleSpawner.OnSpawn.AddListener(new UnityAction<GameObject>(this.ObstacleSpawned));
			this.StartScreen.SetActive(true);
			this.isReady = true;
			this.GameSpeed = 0f;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0003DED3 File Offset: 0x0003C0D3
		public override void Open()
		{
			base.Open();
			this.RefreshHighScore();
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0003DEE1 File Offset: 0x0003C0E1
		protected override void TryPause()
		{
			if (this.isReady)
			{
				this.Close();
				return;
			}
			base.TryPause();
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0003DEF8 File Offset: 0x0003C0F8
		public void Update()
		{
			if (!base.IsOpen)
			{
				return;
			}
			this.Ground.SpeedMultiplier = (base.IsPaused ? 0f : this.GameSpeed);
			this.CharacterFlipboard.SpeedMultiplier = (base.IsPaused ? 0f : this.GameSpeed);
			this.ScoreLabel.text = this.score.ToString("00000");
			for (int i = 0; i < this.clouds.Count; i++)
			{
				if (this.clouds[i] == null || this.clouds[i].gameObject == null)
				{
					this.clouds.RemoveAt(i);
					i--;
				}
				else
				{
					this.clouds[i].SpeedMultiplier = (base.IsPaused ? 0f : this.GameSpeed);
				}
			}
			for (int j = 0; j < this.obstacles.Count; j++)
			{
				if (this.obstacles[j] == null || this.obstacles[j].gameObject == null)
				{
					this.obstacles.RemoveAt(j);
					j--;
				}
				else
				{
					this.obstacles[j].SpeedMultiplier = (base.IsPaused ? 0f : this.GameSpeed);
				}
			}
			float spawnRateMultiplier = Mathf.Sqrt(this.GameSpeed);
			this.ObstacleSpawner.SpawnRateMultiplier = spawnRateMultiplier;
			this.CloudSpawner.SpawnRateMultiplier = spawnRateMultiplier;
			if (this.isReady && (GameInput.GetButtonDown(GameInput.ButtonCode.Jump) || GameInput.GetButtonDown(GameInput.ButtonCode.Forward)))
			{
				this.StartGame();
			}
			if (base.IsPaused || this.GameSpeed == 0f)
			{
				return;
			}
			this.score += (float)this.ScoreRate * Time.deltaTime;
			this.GameSpeed = Mathf.Clamp(this.GameSpeed + this.SpeedIncreaseRate * Time.deltaTime, this.MinGameSpeed, this.MaxGameSpeed);
			if (this.Character.anchoredPosition.y - this.defaultCharacterY > 10f)
			{
				this.CharacterFlipboard.Image.sprite = this.JumpSprite;
				this.CharacterFlipboard.enabled = false;
			}
			else
			{
				this.CharacterFlipboard.enabled = true;
			}
			this.yVelocity -= this.Gravity * this.GlobalForceMultiplier * Time.deltaTime;
			if (this.isJumping && (GameInput.GetButton(GameInput.ButtonCode.Crouch) || GameInput.GetButton(GameInput.ButtonCode.Backward)))
			{
				this.yVelocity -= this.DropForce * this.GlobalForceMultiplier * Time.deltaTime;
			}
			if (this.Character.anchoredPosition.y + this.yVelocity * Time.deltaTime <= this.defaultCharacterY)
			{
				if (this.isJumping)
				{
					this.CharacterFlipboard.SetIndex(0);
				}
				this.Character.anchoredPosition = new Vector2(this.Character.anchoredPosition.x, this.defaultCharacterY);
				this.yVelocity = 0f;
				this.isJumping = false;
				this.isGrounded = true;
			}
			else
			{
				this.Character.anchoredPosition = new Vector2(this.Character.anchoredPosition.x, this.Character.anchoredPosition.y + this.yVelocity * Time.deltaTime);
			}
			if ((GameInput.GetButtonDown(GameInput.ButtonCode.Jump) || GameInput.GetButtonDown(GameInput.ButtonCode.Forward)) && this.isGrounded)
			{
				this.Jump();
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0003E276 File Offset: 0x0003C476
		private void Jump()
		{
			this.isGrounded = false;
			this.isJumping = true;
			this.yVelocity = this.JumpForce * this.GlobalForceMultiplier;
			if (this.onJump != null)
			{
				this.onJump.Invoke();
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003E2AC File Offset: 0x0003C4AC
		private void CloudSpawned(GameObject cloud)
		{
			this.clouds.Add(cloud.GetComponent<UIMover>());
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0003E2BF File Offset: 0x0003C4BF
		private void ObstacleSpawned(GameObject obstacle)
		{
			this.obstacles.Add(obstacle.GetComponent<UIMover>());
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
		private void RefreshHighScore()
		{
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("RunGameHighScore");
			this.HighScoreLabel.text = value.ToString("00000");
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0003E308 File Offset: 0x0003C508
		public void PlayerCollided()
		{
			if (this.isReady)
			{
				return;
			}
			this.EndGame();
			if (this.onHit != null)
			{
				this.onHit.Invoke();
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0003E32C File Offset: 0x0003C52C
		private void EndGame()
		{
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("RunGameHighScore");
			if (this.score > value)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("RunGameHighScore", this.score.ToString(), true);
				this.NewHighScoreAnimation.Play();
				if (this.onNewHighScore != null)
				{
					this.onNewHighScore.Invoke();
				}
			}
			this.GameOverScreen.SetActive(true);
			this.RefreshHighScore();
			this.GameSpeed = 0f;
			this.isReady = true;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		private void StartGame()
		{
			this.ResetGame();
			this.GameSpeed = this.MinGameSpeed;
			this.GameOverScreen.SetActive(false);
			this.StartScreen.SetActive(false);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0003E3DC File Offset: 0x0003C5DC
		private void ResetGame()
		{
			this.score = 0f;
			this.GameSpeed = this.MinGameSpeed;
			this.yVelocity = 0f;
			this.isJumping = false;
			this.isGrounded = true;
			this.isReady = false;
			this.Character.anchoredPosition = new Vector2(this.Character.anchoredPosition.x, this.defaultCharacterY);
			for (int i = 0; i < this.clouds.Count; i++)
			{
				if (this.clouds[i] == null || this.clouds[i].gameObject == null)
				{
					this.clouds.RemoveAt(i);
					i--;
				}
				else
				{
					Object.Destroy(this.clouds[i].gameObject);
				}
			}
			this.clouds.Clear();
			for (int j = 0; j < this.obstacles.Count; j++)
			{
				if (this.obstacles[j] == null || this.obstacles[j].gameObject == null)
				{
					this.obstacles.RemoveAt(j);
					j--;
				}
				else
				{
					Object.Destroy(this.obstacles[j].gameObject);
				}
			}
			this.obstacles.Clear();
		}

		// Token: 0x04000E80 RID: 3712
		public float GameSpeed = 1f;

		// Token: 0x04000E81 RID: 3713
		public float MinGameSpeed = 1.5f;

		// Token: 0x04000E82 RID: 3714
		public float MaxGameSpeed = 4f;

		// Token: 0x04000E83 RID: 3715
		public float SpeedIncreaseRate = 0.1f;

		// Token: 0x04000E84 RID: 3716
		public int ScoreRate = 50;

		// Token: 0x04000E85 RID: 3717
		public float Gravity = 9.8f;

		// Token: 0x04000E86 RID: 3718
		public float JumpForce = 10f;

		// Token: 0x04000E87 RID: 3719
		public float GlobalForceMultiplier = 20f;

		// Token: 0x04000E88 RID: 3720
		public float DropForce = 1f;

		// Token: 0x04000E89 RID: 3721
		public RectTransform Character;

		// Token: 0x04000E8A RID: 3722
		public Flipboard CharacterFlipboard;

		// Token: 0x04000E8B RID: 3723
		public SlidingRect Ground;

		// Token: 0x04000E8C RID: 3724
		public UISpawner CloudSpawner;

		// Token: 0x04000E8D RID: 3725
		public UISpawner ObstacleSpawner;

		// Token: 0x04000E8E RID: 3726
		public TextMeshProUGUI ScoreLabel;

		// Token: 0x04000E8F RID: 3727
		public TextMeshProUGUI HighScoreLabel;

		// Token: 0x04000E90 RID: 3728
		public GameObject StartScreen;

		// Token: 0x04000E91 RID: 3729
		public GameObject GameOverScreen;

		// Token: 0x04000E92 RID: 3730
		public Animation NewHighScoreAnimation;

		// Token: 0x04000E93 RID: 3731
		public Sprite JumpSprite;

		// Token: 0x04000E94 RID: 3732
		private bool isJumping;

		// Token: 0x04000E95 RID: 3733
		private bool isGrounded = true;

		// Token: 0x04000E96 RID: 3734
		private bool isReady;

		// Token: 0x04000E97 RID: 3735
		private float score;

		// Token: 0x04000E98 RID: 3736
		private float yVelocity;

		// Token: 0x04000E99 RID: 3737
		private float defaultCharacterY;

		// Token: 0x04000E9A RID: 3738
		private List<UIMover> clouds = new List<UIMover>();

		// Token: 0x04000E9B RID: 3739
		private List<UIMover> obstacles = new List<UIMover>();

		// Token: 0x04000E9C RID: 3740
		public UnityEvent onJump;

		// Token: 0x04000E9D RID: 3741
		public UnityEvent onHit;

		// Token: 0x04000E9E RID: 3742
		public UnityEvent onNewHighScore;
	}
}
