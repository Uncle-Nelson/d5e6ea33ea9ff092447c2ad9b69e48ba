using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.TV
{
	// Token: 0x02000296 RID: 662
	public class Pong : TVApp
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0003D59D File Offset: 0x0003B79D
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0003D5A5 File Offset: 0x0003B7A5
		public Pong.EGameMode GameMode { get; set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0003D5AE File Offset: 0x0003B7AE
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0003D5B6 File Offset: 0x0003B7B6
		public Pong.EState State { get; set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0003D5BF File Offset: 0x0003B7BF
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0003D5C7 File Offset: 0x0003B7C7
		public int LeftScore { get; set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0003D5D0 File Offset: 0x0003B7D0
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		public int RightScore { get; set; }

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0003D5E1 File Offset: 0x0003B7E1
		private void Update()
		{
			if (!base.IsOpen || base.IsPaused)
			{
				return;
			}
			this.UpdateInputs();
			if (this.GameMode == Pong.EGameMode.SinglePlayer)
			{
				this.UpdateAI();
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003D608 File Offset: 0x0003B808
		private void FixedUpdate()
		{
			if (!base.IsOpen || base.IsPaused)
			{
				this.Ball.RB.isKinematic = true;
				return;
			}
			this.ballVelocity = this.Ball.RB.velocity;
			this.Ball.RB.velocity += this.Ball.RB.velocity.normalized * this.VelocityGainPerSecond * Time.deltaTime;
			if (this.Ball.RB.velocity.magnitude > this.MaxVelocity)
			{
				this.Ball.RB.velocity = this.Ball.RB.velocity.normalized * this.MaxVelocity;
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0003D6E8 File Offset: 0x0003B8E8
		protected override void TryPause()
		{
			this.Ball.RB.isKinematic = true;
			if (this.State == Pong.EState.Ready || this.State == Pong.EState.GameOver)
			{
				this.Close();
				return;
			}
			base.TryPause();
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0003D71C File Offset: 0x0003B91C
		public void UpdateInputs()
		{
			if (this.State == Pong.EState.Playing)
			{
				Vector2 vector;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.Rect, Input.mousePosition, PlayerSingleton<PlayerCamera>.Instance.Camera, ref vector);
				if (this.GameMode == Pong.EGameMode.SinglePlayer)
				{
					this.SetPaddleTargetY(Pong.ESide.Left, vector.y);
					return;
				}
			}
			else if (this.State == Pong.EState.Ready)
			{
				if (GameInput.GetButtonDown(GameInput.ButtonCode.Jump))
				{
					this.ServeBall();
					return;
				}
			}
			else if (this.State == Pong.EState.GameOver && GameInput.GetButtonDown(GameInput.ButtonCode.Jump))
			{
				this.ResetGame();
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0003D798 File Offset: 0x0003B998
		private void UpdateAI()
		{
			if (this.State == Pong.EState.Playing)
			{
				this.reactionTimer += Time.deltaTime;
				if (this.reactionTimer >= this.ReactionTime)
				{
					float t = (Mathf.Clamp01(this.Ball.Rect.anchoredPosition.x / 300f) + 1f) / 2f;
					this.reactionTimer = 0f;
					float num = this.TargetRandomization * Mathf.Lerp(3f, 1f, t);
					float targetY = this.Ball.Rect.anchoredPosition.y + Random.Range(-num, num);
					this.RightPaddle.SetTargetY(targetY);
					this.RightPaddle.SpeedMultiplier = Mathf.Lerp(0.1f, 1f, t) * this.SpeedMultiplier;
				}
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0003D874 File Offset: 0x0003BA74
		public void GoalHit(Pong.ESide side)
		{
			if (this.State != Pong.EState.Playing)
			{
				return;
			}
			if (side == Pong.ESide.Left)
			{
				int num = this.RightScore;
				this.RightScore = num + 1;
				if (this.onRightScore != null)
				{
					this.onRightScore.Invoke();
				}
			}
			else
			{
				int num = this.LeftScore;
				this.LeftScore = num + 1;
				if (this.onLeftScore != null)
				{
					this.onLeftScore.Invoke();
				}
			}
			this.LeftScoreLabel.text = this.LeftScore.ToString();
			this.RightScoreLabel.text = this.RightScore.ToString();
			this.Ball.RB.velocity = Vector3.zero;
			this.Ball.RB.isKinematic = true;
			this.State = Pong.EState.Ready;
			if (this.LeftScore >= this.GoalsToWin)
			{
				this.Win(Pong.ESide.Left);
				return;
			}
			if (this.RightScore >= this.GoalsToWin)
			{
				this.Win(Pong.ESide.Right);
			}
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0003D960 File Offset: 0x0003BB60
		private void Win(Pong.ESide winner)
		{
			if (winner == Pong.ESide.Left)
			{
				this.WinnerLabel.text = "Player 1 Wins!";
				this.WinnerLabel.color = this.LeftPaddle.GetComponent<Image>().color;
				if (this.onLocalPlayerWin != null)
				{
					this.onLocalPlayerWin.Invoke();
				}
			}
			else
			{
				this.WinnerLabel.text = "Player 2 Wins!";
				this.WinnerLabel.color = this.RightPaddle.GetComponent<Image>().color;
			}
			this.State = Pong.EState.GameOver;
			if (this.onGameOver != null)
			{
				this.onGameOver.Invoke();
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
		private void ResetBall()
		{
			this.Ball.RB.isKinematic = true;
			this.Ball.Rect.anchoredPosition = Vector2.zero;
			this.Ball.transform.localPosition = Vector3.zero;
			this.Ball.transform.localRotation = Quaternion.identity;
			this.Ball.RB.velocity = Vector3.zero;
			this.Ball.RB.isKinematic = false;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0003DA7C File Offset: 0x0003BC7C
		private void ServeBall()
		{
			this.ResetBall();
			this.Ball.RB.isKinematic = false;
			if (this.nextBallSide == Pong.ESide.Left)
			{
				Vector2 normalized = new Vector2(-1f, Random.Range(-0.5f, 0.5f)).normalized;
				this.Ball.RB.AddRelativeForce(normalized * this.InitialVelocity, 2);
			}
			else
			{
				Vector2 normalized2 = new Vector2(1f, Random.Range(-0.5f, 0.5f)).normalized;
				this.Ball.RB.AddRelativeForce(normalized2 * this.InitialVelocity, 2);
			}
			this.State = Pong.EState.Playing;
			this.nextBallSide = ((this.nextBallSide == Pong.ESide.Left) ? Pong.ESide.Right : Pong.ESide.Left);
			if (this.onServe != null)
			{
				this.onServe.Invoke();
			}
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0003DB60 File Offset: 0x0003BD60
		private void ResetGame()
		{
			this.State = Pong.EState.Ready;
			this.LeftScore = 0;
			this.RightScore = 0;
			this.LeftScoreLabel.text = this.LeftScore.ToString();
			this.RightScoreLabel.text = this.RightScore.ToString();
			this.ResetBall();
			this.nextBallSide = Pong.ESide.Left;
			this.ballVelocity = Vector3.zero;
			if (this.onReset != null)
			{
				this.onReset.Invoke();
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0003DBDF File Offset: 0x0003BDDF
		public void SetPaddleTargetY(Pong.ESide player, float y)
		{
			if (player == Pong.ESide.Left)
			{
				this.LeftPaddle.SetTargetY(y);
				return;
			}
			this.RightPaddle.SetTargetY(y);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0003DBFD File Offset: 0x0003BDFD
		public override void Resume()
		{
			base.Resume();
			this.Ball.RB.isKinematic = false;
			this.Ball.RB.velocity = this.ballVelocity;
		}

		// Token: 0x04000E55 RID: 3669
		public RectTransform Rect;

		// Token: 0x04000E56 RID: 3670
		public PongPaddle LeftPaddle;

		// Token: 0x04000E57 RID: 3671
		public PongPaddle RightPaddle;

		// Token: 0x04000E58 RID: 3672
		public PongBall Ball;

		// Token: 0x04000E59 RID: 3673
		public TextMeshProUGUI LeftScoreLabel;

		// Token: 0x04000E5A RID: 3674
		public TextMeshProUGUI RightScoreLabel;

		// Token: 0x04000E5B RID: 3675
		public TextMeshProUGUI WinnerLabel;

		// Token: 0x04000E5C RID: 3676
		[Header("Settings")]
		public float InitialVelocity = 0.8f;

		// Token: 0x04000E5D RID: 3677
		public float VelocityGainPerSecond = 0.05f;

		// Token: 0x04000E5E RID: 3678
		public float MaxVelocity = 2f;

		// Token: 0x04000E5F RID: 3679
		public int GoalsToWin = 10;

		// Token: 0x04000E60 RID: 3680
		[Header("AI")]
		public float ReactionTime = 0.1f;

		// Token: 0x04000E61 RID: 3681
		public float TargetRandomization = 10f;

		// Token: 0x04000E62 RID: 3682
		public float SpeedMultiplier = 0.5f;

		// Token: 0x04000E63 RID: 3683
		public UnityEvent onServe;

		// Token: 0x04000E64 RID: 3684
		public UnityEvent onLeftScore;

		// Token: 0x04000E65 RID: 3685
		public UnityEvent onRightScore;

		// Token: 0x04000E66 RID: 3686
		public UnityEvent onGameOver;

		// Token: 0x04000E67 RID: 3687
		public UnityEvent onLocalPlayerWin;

		// Token: 0x04000E68 RID: 3688
		public UnityEvent onReset;

		// Token: 0x04000E69 RID: 3689
		private Pong.ESide nextBallSide;

		// Token: 0x04000E6A RID: 3690
		private Vector3 ballVelocity = Vector3.zero;

		// Token: 0x04000E6B RID: 3691
		private float reactionTimer;

		// Token: 0x02000297 RID: 663
		public enum EGameMode
		{
			// Token: 0x04000E6D RID: 3693
			SinglePlayer,
			// Token: 0x04000E6E RID: 3694
			MultiPlayer
		}

		// Token: 0x02000298 RID: 664
		public enum ESide
		{
			// Token: 0x04000E70 RID: 3696
			Left,
			// Token: 0x04000E71 RID: 3697
			Right
		}

		// Token: 0x02000299 RID: 665
		public enum EState
		{
			// Token: 0x04000E73 RID: 3699
			Ready,
			// Token: 0x04000E74 RID: 3700
			Playing,
			// Token: 0x04000E75 RID: 3701
			GameOver
		}
	}
}
